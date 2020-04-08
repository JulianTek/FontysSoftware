namespace DBTestMockup.Data
{
    public class EmpDto
    {

        public EmpDto()
        {

        }

        public EmpDto(string Name)
        {
            this.Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return string.Format("({0})", Name);
        }
    }
}