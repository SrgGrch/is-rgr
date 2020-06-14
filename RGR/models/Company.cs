namespace RGR.models {
    public class Company {
        public int id {  get; set; }
        public string name {  get; set; }
        public string description {  get; set; }

        public Company() { }

        public Company(int id, string name, string description) {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}