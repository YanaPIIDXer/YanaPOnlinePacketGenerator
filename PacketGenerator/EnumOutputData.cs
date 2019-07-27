using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketGenerator
{
	/// <summary>
	/// enum出力先データ
	/// </summary>
	public class EnumOutputData
	{
		/// <summary>
		/// 言語
		/// </summary>
		public enum ELanguage
		{
			/// <summary>
			/// C++
			/// </summary>
			Cpp,

			/// <summary>
			/// C#
			/// </summary>
			CSharp,
		}

		/// <summary>
		/// パス
		/// </summary>
		public string Path { get; private set; }

		/// <summary>
		/// 言語
		/// </summary>
		public ELanguage Language { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="InPath">パス</param>
		/// <param name="InLanguage">言語</param>
		public EnumOutputData(string InPath, string InLanguage)
		{
			Path = InPath;
			switch (InLanguage)
			{
				case "C++":

					Language = ELanguage.Cpp;
					break;

				case "C#":

					Language = ELanguage.CSharp;
					break;

				default:

					throw new Exception(InLanguage + "は不明な言語です。");
			}
		}
	}
}
