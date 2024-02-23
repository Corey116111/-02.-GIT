//https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit
namespace ClassLibrary1
{
    public class Auditoria
    {
        private string name;
        private string ref_to_sotrudnik;
        private int count_places;
        private int count_windows;
        private string[] oborudovanie;
        public Auditoria(string name, string ref_to_sotrudnik, int count_places, int count_windows, string[] oborudovanie)
        {
            this.name = name;
            this.ref_to_sotrudnik = ref_to_sotrudnik;
            this.count_places = count_places; 
            this.count_windows = count_windows;
            this.oborudovanie = oborudovanie;
        }
    }
}
