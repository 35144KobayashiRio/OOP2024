namespace Section01 {
    internal class Employee {
        private string v1;
        private string v2;

        public string Name { get; set; }
        public int Id { get; set; }

        public Employee(int id, string name) {
            Id = id;
            Name = name;


        }

        public Employee(string v1, string v2) {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}