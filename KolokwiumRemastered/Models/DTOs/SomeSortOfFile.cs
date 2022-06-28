namespace KolokwiumRemastered.Models.DTOs
{
    public class SomeSortOfFile
    {
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public int FileSize { get; set; }

        SomeSortOfTeam Team { get; set; }


    }
}
