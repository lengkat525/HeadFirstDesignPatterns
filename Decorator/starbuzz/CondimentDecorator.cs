﻿namespace Decorator.starbuzz
{
    public abstract class CondimentDecorator : Beverage
   {
       //private Beverage beverage;
       public abstract override string GetDescription();
   }
}
//调料，也是装饰类
//抽象装饰者