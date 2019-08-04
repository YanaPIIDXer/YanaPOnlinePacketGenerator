using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketGenerator
{
	/// <summary>
	/// パケットデータ
	/// </summary>
	public class PacketData
	{
		/// <summary>
		/// パケット名
		/// </summary>
		public string Name;

		/// <summary>
		/// パケットか？
		/// falseならただの構造体。
		/// </summary>
		public bool IsPacket;

		/// <summary>
		/// パケットＩＤ
		/// </summary>
		public string ID;

		/// <summary>
		/// メンバ
		/// </summary>
		public List<PacketMemberData> Member;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PacketData()
		{
			Name = "";
			IsPacket = true;
			ID = "";
			Member = new List<PacketMemberData>();
		}
	}

	/// <summary>
	/// パケットメンバデータ
	/// </summary>
	public class PacketMemberData
	{
		/// <summary>
		/// メンバ名
		/// </summary>
		public string Name;

		/// <summary>
		/// メンバ型
		/// </summary>
		public string Type;

		/// <summary>
		/// ToString
		/// </summary>
		/// <returns>メンバ名</returns>
		public override string ToString()
		{
			return Name;
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PacketMemberData()
		{
			Name = "";
			Type = "";
		}
	}
}
