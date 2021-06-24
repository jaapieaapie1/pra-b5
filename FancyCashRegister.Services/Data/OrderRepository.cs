using FancyCashRegister.Domain.Models;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Services.Data
{
    /// <summary>
    /// Deze repository gaat uit van onderstaande tabel definitie:
    /// 
    ///		drop table if exists orders;
    ///		create table orders(
    ///			order_id int primary key auto_increment,
    ///		    datumtijd_aanmaak datetime not null
    ///		);
    ///		
    ///		drop table if exists order_producten;
    ///		create table order_producten(
    ///			order_id int not null,
    ///		    product_id int not null,
    ///		    aantal int,
    ///		    verkoopprijs decimal(14,2)
    ///		);
    ///		
    ///		alter table order_producten
    ///			add constraint `fk_order` 
    ///				foreign key (order_id) references orders(order_id),
    ///		    add constraint `fk_product`
    ///				foreign key (product_id) references producten(product_id);
    /// </summary>
    public class OrderRepository : BaseDbRepository
    {
        public OrderRepository() : base()
        {
        }

        public IEnumerable<Order> Orders { get; set; }

        public Order AddOrder(Order order)
        {
            var paramDtAanmaak = "@dt_aanmaak";

            // eerst order aanmaken -->
            var qryInsertOrder = $@"insert into orders
(datumtijd_aanmaak) 
values({paramDtAanmaak});";

            var datumAanmaak = new MySqlDateTime(order.AanmaakDatum.DateTime);

            (var orderInsertSuccess, var newOrderId) = InsertQuery(
                qryInsertOrder,
                new MySqlParameter(paramDtAanmaak, MySqlDbType.DateTime)
                );

            if (orderInsertSuccess)
            {
                // nieuw id toewijzen aan de order -->
                order.Id = newOrderId;

                // vervolgens de producten in de order aanmaken in de associative tabel -->
                var paramOrderId = "@order_id";
                var paramProductId = "@product_id";
                var paramAantalItems = "@aantal";
                var paramVerkoopprijs = "@verkoopprijs";
                var qryInsertOrderProducts = $@"insert into order_producten
(order_id, product_id, aantal, verkoopprijs) 
values({paramOrderId}, {paramProductId}, {paramAantalItems}, {paramVerkoopprijs})";

                foreach (var productOrder in order.Producten)
                {
                    var parameters = new[]
                    {
                    new MySqlParameter(paramOrderId, order.Id),
                    new MySqlParameter(paramProductId, productOrder.Id),
                    new MySqlParameter(paramAantalItems, productOrder.Aantal),
                    new MySqlParameter(paramVerkoopprijs, productOrder.Stuksprijs),

                };
                    (var productOrderSuccess, _) = InsertQuery(qryInsertOrderProducts, parameters);
                    // TODO: wat te doen als order is aangemaakt maar producten in order geeft fout...
                    // (transactie start / commit / rollback)
                }
            }


            // pass by ref maar toch teruggeven zodat semantisch het plaatje klopt -->
            return order;
        }

        public bool UpdateOrder(Order order)
        {
            var paramOrderId = "@order_id";
            var paramDtAanmaak = "@dt_aanmaak";

            var qry = $@"update order set datumtijd_aanmaak = {paramDtAanmaak} where order_id = {paramOrderId};";
            var parameters = new[] {
                new MySqlParameter(paramOrderId, order.Id),
                new MySqlParameter(paramDtAanmaak, order.AanmaakDatum)
            };
            var success = UpdateQuery(qry, parameters);

            return success;
        }

        public bool DeleteOrder(Order order)
        {
            var paramOrderId = "@order_id";
            var qry = $@"delete from orders where order_id = {paramOrderId};";

            var success = DeleteQuery(qry, new MySqlParameter(paramOrderId, order.Id));

            return success;
        }
    }
}
