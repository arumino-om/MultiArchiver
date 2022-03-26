/*      ～ アーカイブ情報定義コード ～
 * このコードは、アーカイブの情報を定義・取得
 * するために使用するコードです。
 * 
 * アーカイブを追加するときは、このコードに
 * 情報を追加してください。
 * 
 */

namespace MultiArchiveLibrary
{
    internal class ArchiveDefinition
    {
    }

    internal struct ArchiveDefinitionStruct
    {
        /// <summary>
        /// アーカイブの名前、または総称
        /// </summary>
        public string ArchiveName { get; init; }

        /// <summary>
        /// アーカイブが使用するファイル拡張子
        /// </summary>
        public string[] FileExtensions { get; init; }

        /// <summary>
        /// アーカイブを操作するクラス名 (IArchiverを継承したクラスであること)
        /// </summary>
        public string ArchiverClassName { get; init; }
    }
}
