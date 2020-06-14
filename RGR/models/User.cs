namespace RGR.models {
    public class User {
        public int id {  get; set; }
        public string name {  get; set; }
        public string nickname {  get; set; }
        public string email {  get; set; }
        public Company company {  get; set; }


        public User() { }

        public User(int id, string name, string nickname, string email, Company company) {
            this.id = id;
            this.name = name;
            this.nickname = nickname;
            this.email = email;
            this.company = company;
        }
    }
}