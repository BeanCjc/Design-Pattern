﻿目的:
	在软件构件过程中有些对象使用的算法并不是一成不变的,会时常变化.故可以将算法抽象出来然后在各个子类中实现不同的算法提供给该对象调用,达到了应对变化的算法
优点:
	由于具体策略角色类实现的都是同一个接口或抽象类,故他们可以随意切换
	易于扩展,当新增一个策略时只需增加一个类就行无需修改原来的代码
	避免使用多重条件语句(if、else if、else if、else if、else),充分体现面向对象设计思想
缺点:
	客户端必须知道所有的策略类,并且需要知道调用哪个策略类
	如果算法很多的话会造成很多的策略类
应用:
	一个系统需要动态的在几种算法中选择一种的情况下,可以将这些算法封装到一个类中并为这些具体的算法提供一个统一的接口
	如果一个对象有很多行为,此时只能用多个if else来实现.这是可以使用策略模式将这些行为转移到相应的策略类里面,就可以避免使用多重if else语句