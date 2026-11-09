namespace Person.Models
{
    public class PersonModel
    {
        public PersonModel(string name)
        {
            this.name = name;
            id = Guid.NewGuid();
        }

        public Guid id { get; private set; }

        public string name { get; private set; }

        public void ChangeName(String name)
        {
            this.name = name;
        }

        public void setDesactive()
        {
            this.name = "desativado";
        }

    }
}