using StateMachine2;

string S = "IGRAIGRIGRIGRIGR";
BallMachine ballMachine = new BallMachine();

for(int i = 0; i < S.Length; i++)
{
    if (S[i]== 'I')
    {
        ballMachine.InsertCoin();
        continue;
    }

    if (S[i] == 'G')
    {
        ballMachine.GetBall();
        continue;
    }

    if (S[i] == 'R')
    {
        ballMachine.ReturnCoin();
        continue;
    }

    if (S[i] == 'A')
    {
        ballMachine.AddBall();
        continue;
    }
}