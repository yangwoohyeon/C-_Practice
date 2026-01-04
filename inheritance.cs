using System;

class Robot{
    public void Move(){
        Console.WriteLine("로봇이 움직입니다.");
    }
}

class CleanRobot : Robot{

    public void Move(){
        Console.WriteLine("청소 로봇이 움직입니다.");
    }
    public void Clean(){
        Console.WriteLine("로봇이 청소를 합니다.");
    }
}