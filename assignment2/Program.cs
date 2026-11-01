List <List<Object>> users = new List<List<Object>> () ;
List <Object> user1 = new List<Object> () ;
user1.Add(920);
user1.Add("salma");
user1.Add("cairo");
users.Add(user1);

bool Exit = true ;

Console.WriteLine("Hello, Welcome to our application.");
int i = 0;
while( i >= 0 && Exit == true )
{
    Console.WriteLine("1.Show all users.\n2.Show user iformation.\n3.Add new user\n4.Delete user.\n5.Exit application.");
    Console.WriteLine("Please enter the number of operation you want to do:");
    string operationInput = Console.ReadLine();
    int operation = int.Parse(operationInput);
    switch ( operation )
    {
        case 1 :
            Console.WriteLine("our customers are:\n");
            foreach(List<Object> user in users)
            {
                foreach(Object information in user)
                {
                    Console.WriteLine(information);
                }
            }
        break;
        

        case 2 :
            Console.WriteLine("enter the number of user you want to see their information:");
            string userInput = Console.ReadLine();
            int userNum = int.Parse(userInput);
            if ( userNum >= 1 && userNum <=   users.Count )
            {
                foreach(Object information in users[userNum - 1])
                {
                    Console.WriteLine(information);
                }
            }
            break;
        
        case 3 :
            Console.WriteLine("enter the user id number:");
            string userIdInput = Console.ReadLine();
            int userId = int.Parse(userIdInput);
            Console.WriteLine("enter the user name:");
            string userName = Console.ReadLine();
            Console.WriteLine("enter the user city:");
            string userCity = Console.ReadLine();
            List <Object> user3 = new List<object> ();
            user3.Add(userId);
            user3.Add(userName);
            user3.Add(userCity);
            users.Add(user3);
            break;


        case 4 :
            Console.WriteLine("enter the number of user you want to delet:");
            string deleteuserInput = Console.ReadLine();
            int deleteuserNum = int.Parse(deleteuserInput);
            if ( deleteuserNum >= 1 && deleteuserNum <= users.Count )
            {
                users.RemoveAt(deleteuserNum-1);
                Console.WriteLine($"the user{deleteuserNum} is deleted.");
            }
            break;
        

        case 5 :
            Console.WriteLine("thank you for using our application.");
            Exit = false ;
            break;
    }
    i++;
}