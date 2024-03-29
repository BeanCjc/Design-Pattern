﻿目的:由于简单工厂模式在需要扩展时不得不修改工厂类,违背了设计原则中的OCP原则(开闭原则);恰好工厂方法模式可以解决这个问题
	工厂方法模式定义一个创建对象的接口,让子类决定实例化哪个类.工厂方法使得一个类的实例延迟到子类
优点:
	在工厂方法模式中,客户端只需要知道所要产品的具体工厂,无需关心具体的创建过程,甚至不需要知道具体产品的类名
	在系统增加新的产品时,我们只需增加一个具体产品类和对应的实现工厂,无需对原工厂进行任何修改,很好的符合了"开闭原则"
缺点:
	每次增加一个新产品时,都需要增加一个产品类和对应的实现工厂,使得系统中类的个数不断增加,一定程度上增加了系统的复杂度,同时也增加了系统具体类的依赖,这并不是什么好事
应用:
	一个类不知道它所需对象的类.在工厂方法模式中我们不需要知道具体的产品名称,我们只需知道创建它的工厂即可
	一个类通过其子类来指定创建哪个对象.在工厂方法模式中,对于抽象工厂类只需提供一个创建产品的接口,而由其子类来确定具体要创建的对象,在程序运行时,其子类对象将覆盖父类对象,从而使系统更易于扩展
	将创建对象的任务委托给多个子类中的某一个,客户端在使用时可以无需关心是哪一个工厂子类创建的产品子类,需要时再动态指定