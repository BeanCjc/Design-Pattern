using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("--------------------ObserverPattern--------------------");
            Console.WriteLine();
            Subject subject1 = new ConcreteSubject("我是订阅号1");
            Subject subject2 = new ConcreteSubject("我是订阅号2");
            Observer observer1 = new ConcreteObserver("我是观察者1");
            Observer observer2 = new ConcreteObserver("我是观察者2");
            Observer observer3 = new ConcreteObserver("我是观察者3");
            subject1.AddObserver(observer1);
            subject2.AddObserver(observer1);
            subject2.AddObserver(observer2);
            observer3.AddSubject(subject2);
            subject1.PublishMessage("订阅号1发布了第1条消息");
            subject2.PublishMessage("订阅号2发布了第1条消息");
            subject1.PublishMessage("订阅号1发布了第2条消息");
            subject2.PublishMessage("订阅号2发布了第2条消息");
            Console.ReadKey();
        }
    }
}
