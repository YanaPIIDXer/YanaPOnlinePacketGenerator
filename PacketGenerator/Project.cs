﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace PacketGenerator
{
	/// <summary>
	/// プロジェクトクラス
	/// </summary>
	public class Project
	{

		#region StaticMethodAndField

		/// <summary>
		/// 基本XMLファイル名
		/// </summary>
		private static readonly string BasicXmlFileName = @"Project.xml";

		/// <summary>
		/// 基本XMLファイルの最上位要素名
		/// </summary>
		private static readonly string XmlRootElementName = @"root";

		/// <summary>
		/// パケットＩＤenumの要素名
		/// </summary>
		private static readonly string PacketIDEnumElementName = @"PacketIDEnum";

		/// <summary>
		/// パケットの要素名
		/// </summary>
		private static readonly string PacketElementName = @"Packet";

		/// <summary>
		/// パケットメンバの要素名
		/// </summary>
		private static readonly string MemberElementName = @"Member";

		/// <summary>
		/// 生成
		/// </summary>
		/// <param name="ProjectName">プロジェクト名</param>
		public static void Create(string ProjectName)
		{
			var Path = Config.ProjectRootDir + ProjectName + "\\";

			// ディレクトリ
			Directory.CreateDirectory(Path);

			// 基本XML
			XmlDocument Xml = new XmlDocument();
			XmlElement Root = Xml.CreateElement(XmlRootElementName);
			Xml.AppendChild(Root);
			Xml.Save(Path + BasicXmlFileName);
		}

		/// <summary>
		/// 有効なプロジェクトか？
		/// </summary>
		/// <param name="ProjectName">プロジェクト名</param>
		/// <returns>有効ならtrueを返す</returns>
		public static bool IsValid(string ProjectName)
		{
			var Path = Config.ProjectRootDir + ProjectName + "\\";

			// ディレクトリが存在するか？
			if (!Directory.Exists(Path)) { return false; }

			// 基本XMLファイルが存在するか？
			try
			{
				XmlDocument Xml = new XmlDocument();
				Xml.Load(Path + BasicXmlFileName);
				if (Xml.SelectSingleNode(XmlRootElementName) == null) { return false; }
			}
			catch { return false; }

			return true;
		}

		#endregion

		/// <summary>
		/// プロジェクトのパス
		/// </summary>
		private string ProjectPath = "";
		
		/// <summary>
		/// 基本XML
		/// </summary>
		XmlDocument BasicXml = null;

		/// <summary>
		/// XMLのルート要素
		/// </summary>
		XmlNode XmlRootNode = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="Name">プロジェクト名</param>
		public Project(string Name)
		{
			BasicXml = new XmlDocument();
			ProjectPath = Config.ProjectRootDir + Name + @"\";
			BasicXml.Load(ProjectPath + BasicXmlFileName);
			XmlRootNode = BasicXml.SelectSingleNode(XmlRootElementName);
		}

		/// <summary>
		/// パケットＩＤのenumを追加。
		/// </summary>
		/// <param name="EnumName">enum名</param>
		/// <param name="Output1">出力先１</param>
		/// <param name="Output2">出力先２</param>
		/// <returns>新規追加されたらtrueを返す。※既に存在するenum名ならfalseを返す。</returns>
		public bool AddPacketIDEnum(string EnumName, EnumOutputData Output1, EnumOutputData Output2)
		{
			var Childs = XmlRootNode.ChildNodes;
			foreach(XmlNode Child in Childs)
			{
				if(Child.Name == EnumName) { return false; }
			}

			// 基本XMLへの登録
			XmlElement EnumElement = BasicXml.CreateElement(PacketIDEnumElementName);
			EnumElement.SetAttribute("Name", EnumName);

			XmlElement Output1Element = BasicXml.CreateElement("Output1");
			Output1Element.SetAttribute("Path", Output1.Path);
			Output1Element.SetAttribute("Language", Output1.Language.ToString());
			EnumElement.AppendChild(Output1Element);

			XmlElement Output2Element = BasicXml.CreateElement("Output2");
			Output2Element.SetAttribute("Path", Output2.Path);
			Output2Element.SetAttribute("Language", Output2.Language.ToString());
			EnumElement.AppendChild(Output2Element);

			XmlRootNode.AppendChild(EnumElement);

			// Enum用のXMLファイルを生成。
			XmlDocument EnumXml = new XmlDocument();
			XmlElement EnumRoot = EnumXml.CreateElement(XmlRootElementName);
			EnumXml.AppendChild(EnumRoot);

			EnumXml.Save(ProjectPath + EnumName + ".xml");
			BasicXml.Save(ProjectPath + BasicXmlFileName);

			return true;
		}

		/// <summary>
		/// パケット追加
		/// </summary>
		/// <param name="EnumName">パケットを追加するenum</param>
		/// <param name="Data">パケットデータ</param>
		public void AddPacket(string EnumName, PacketData Data)
		{
			XmlDocument EnumXml = new XmlDocument();
			EnumXml.Load(ProjectPath + EnumName + ".xml");

			XmlNode RootNode = EnumXml.SelectSingleNode(XmlRootElementName);
			XmlElement PacketElement = null;
			bool bIsUpdate = false;
			foreach(XmlElement Child in RootNode.ChildNodes)
			{
				if(Child.GetAttribute("Name") == Data.Name)
				{
					PacketElement = Child;
					PacketElement.RemoveAll();
					bIsUpdate = true;
				}
			}

			if(!bIsUpdate)
			{
				PacketElement = EnumXml.CreateElement(PacketElementName);
			}
			PacketElement.SetAttribute("Name", Data.Name);
			PacketElement.SetAttribute("IsPacket", Data.IsPacket.ToString());
			PacketElement.SetAttribute("ID", Data.ID);

			foreach(var Member in Data.Member)
			{
				XmlElement MemberElement = EnumXml.CreateElement(MemberElementName);
				MemberElement.SetAttribute("Name", Member.Name);
				MemberElement.SetAttribute("Type", Member.Type);
				PacketElement.AppendChild(MemberElement);
			}

			if(!bIsUpdate)
			{
				RootNode.AppendChild(PacketElement);
			}

			EnumXml.Save(ProjectPath + EnumName + ".xml");
		}

		/// <summary>
		/// パケットリストを取得
		/// </summary>
		/// <param name="EnumName">enum名</param>
		/// <returns>パケットリスト</returns>
		public PacketData[] GetPackets(string EnumName)
		{
			List<PacketData> Packets = new List<PacketData>();

			XmlDocument EnumXml = new XmlDocument();
			EnumXml.Load(ProjectPath + EnumName + ".xml");
			
			XmlNode RootNode = EnumXml.SelectSingleNode(XmlRootElementName);
			foreach(XmlElement PacketNode in RootNode.ChildNodes)
			{
				PacketData Data = new PacketData();
				Data.Name = PacketNode.GetAttribute("Name");
				Data.IsPacket = (PacketNode.GetAttribute("IsPacket") == "True");
				Data.ID = PacketNode.GetAttribute("ID");

				foreach(XmlElement MemberNode in PacketNode.ChildNodes)
				{
					PacketMemberData MemberData = new PacketMemberData();
					MemberData.Name = MemberNode.GetAttribute("Name");
					MemberData.Type = MemberNode.GetAttribute("Type");
					Data.Member.Add(MemberData);
				}

				Packets.Add(Data);
			}

			return Packets.ToArray();
		}

		/// <summary>
		/// enumリストを列挙
		/// </summary>
		/// <returns>enumリスト</returns>
		public string[] CollectEnumList()
		{
			List<string> Enums = new List<string>();
			var Xmls = Directory.GetFiles(ProjectPath, "*.xml");
			foreach (var Xml in Xmls)
			{
				string FileName = Path.GetFileNameWithoutExtension(Xml);
				if (FileName == Path.GetFileNameWithoutExtension(BasicXmlFileName)) { continue; }
				Enums.Add(FileName);
			}

			return Enums.ToArray();
		}
	}
}
