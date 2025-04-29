using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy2
{
    // Estrategia base
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal price);
    }

    // Sin descuento
    public class NoDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price;
        }
    }

    // Descuento de Navidad
    public class ChristmasDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.9m; // 10% de descuento
        }
    }

    // Descuento de Black Friday
    public class BlackFridayDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal price)
        {
            return price * 0.7m; // 30% de descuento
        }
    }

    // Contexto
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;

        public ShoppingCart(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal price)
        {
            return _discountStrategy.ApplyDiscount(price);
        }
    }

    class ProgramStrategy2
    {
        static void Main(string[] args)
        {
            var cart = new ShoppingCart(new NoDiscountStrategy());

            decimal price = 100m;
            Console.WriteLine($"Total sin descuento: {cart.CalculateTotal(price)}"); // 100

            cart.SetDiscountStrategy(new ChristmasDiscountStrategy());
            Console.WriteLine($"Total con descuento de Navidad: {cart.CalculateTotal(price)}"); // 90

            cart.SetDiscountStrategy(new BlackFridayDiscountStrategy());
            Console.WriteLine($"Total con descuento de Black Friday: {cart.CalculateTotal(price)}"); // 70
        }
    }
}
