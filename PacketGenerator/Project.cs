using System;
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

	}
}
