namespace Practice
{
    public class Tourist
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Place {  get; set; }

        public string Info()
        {
            return Age + "," + Place;
        }
    }
}
