Console.Clear();

int time = 0;
int count = 0;
int distance = 10000;
int firstFriendSpeed = 1;
int secontFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance/(firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else 
    {
        time = distance/(secontFriendSpeed + dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secontFriendSpeed)*time;
    count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз ");
