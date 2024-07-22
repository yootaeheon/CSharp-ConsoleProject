namespace OOP
{
    internal class Program
    {
        class Character
        {
            public int field;
            public int level;
            public float speed;
            public int attack;

            private int hp = 100;

            public void GoForward()
            {
                speed += 10;
            }
            public void GoBackWard()
            {
                speed -= 10;
            }
            public void TurnRight90()
            {
                //우회전
            }
            public void TurnLeft90()
            {
                //좌회전
            }
            public void Attack()
            {
                Console.WriteLine($"캐릭터가 {attack}만큼 공격합니다.");
            }
            public void GetDamage(int damage)
            {
                Console.WriteLine($"캐릭터가 {damage}의 피해를 입었습니다.");
                hp -= damage;

            }
        }

        static void Main(string[] args)
        {
            Character player1 = new Character();

            player1.attack = 30;
            player1.speed = 10;

            player1.GoForward();
            player1.Attack();
            player1.GetDamage(10);
        }
    }
}