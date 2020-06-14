namespace RGR.models {
    public class Place {
        public int id {  get; set; }
        public string name {  get; set; }
        public string description {  get; set; }

        public Place() { }

        public Place(int id, string name, string description) {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}