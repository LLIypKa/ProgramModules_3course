using StateMachine;

Context context = new Context("Текст с \" литералами и {некомментариям} \" и {комментариями и не \"литералами\"}.");
string answer;

answer = context.Request();
Console.WriteLine(answer);
while(!string.IsNullOrEmpty(answer))
{
    answer = context.Request();
    Console.WriteLine(answer);
}