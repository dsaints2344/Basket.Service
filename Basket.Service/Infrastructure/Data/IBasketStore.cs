
namespace Basket.Service.Infrastructure.Data;

internal interface IBasketStore
{
   CustomerBasket GetBasketByCustomerId(string customerId);
}