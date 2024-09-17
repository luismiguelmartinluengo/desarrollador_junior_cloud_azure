Console.WriteLine(new Random().Next(2)==0?"head":"tails");

string permission = "User";
int level = 90;

if(permission.Contains("Admin")){
    Console.WriteLine(level>55?"Welcome, Super Admin user.":"Welcome, Admin user.");
}else if (permission.Contains("Manager")){
    Console.WriteLine(level > 20?"Contact an Admin for access.":"You do not have sufficient privileges.");
}else{
    Console.WriteLine("You do not have sufficient privileges.");
}//End if

Console.WriteLine(permission.Contains("Admin")?(level>55?"Welcome, Super Admin user.":"Welcome, Admin user."):permission.Contains("Manager")?(level > 20?"Contact an Admin for access.":"You do not have sufficient privileges."):"You do not have sufficient privileges.");
