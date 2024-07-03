namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<Userinfo> _users = new();

        static Repository()
        {
            _users.Add(new Userinfo() {Id=1,Name = "Ali", Email = "abc@gmail.com", Phone = "1412321111", WillAttend=true });
            _users.Add(new Userinfo() {Id=2,Name = "Ahmet", Email = "abce@gmail.com", Phone = "11232111", WillAttend=false });
            _users.Add(new Userinfo() {Id=3,Name = "Mehmet", Email = "abcd@gmail.com", Phone = "111121211", WillAttend=true });


        }
        

        public static List<Userinfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(Userinfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static Userinfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}
