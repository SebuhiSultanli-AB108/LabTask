using E_commerce.BL.Service.OrderItemItem;
using E_commerce.BL.Service.OrderItems;
using E_commerce.BL.Service.Orders;
using E_commerce.BL.Service.Products;
using E_commerce.Core.Entities;
using E_commerce.Core.IRepositories;
using E_commerce.DAL.Repositories;

namespace E_commerce;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddScoped<IOrderItemService, OrderItemService>();
        builder.Services.AddScoped<IOrderService, OrderService>();
        builder.Services.AddScoped<IProductService, ProductService>();
        builder.Services.AddScoped<IRepository<Order>, Repository<Order>>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
