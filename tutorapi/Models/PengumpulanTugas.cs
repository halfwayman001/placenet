namespace tutorapi.Models
{
    public class PengumpulanTugas
    {
        public int id {  get; set; }
        public int tugas_id { get; set; }
        public int mahasiswa_id { get; set; }
        public string kumpulan_tugas { get; set; }
        public int nilai {  get; set; }
    }
}
