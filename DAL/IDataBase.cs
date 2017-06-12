using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDataBase
    {
        #region Customer

        void addCustomer(Customer d);

        bool delCustomer(int custID);

        void updateCustomer(int custID, Customer s);

        Customer getDish(int custID);

        #endregion

        #region Dough

    

        void addDough(Dough d);

        bool delDough(int doughID);

        void updateDough(int doughID, Dough s);

        Dough getDough(int doughID);

        #endregion

        #region Employee

       

        void addEmployee(Employee d);

        bool delEmployee(int empID);

        void updateEmployee(int empID, Employee s);

        Employee getEmployee(int empID);


        #endregion

        #region Order

        void addOrder(Order d);

        bool delOrder(int orderID);

        void updateOrder(int orderID, Order s);

        Order getOrder(int orderID);

        #endregion

        #region Pizza

        void addPizza(Pizza d);

        bool delPizza(int pizzaID);

        void updatePizza(int pizzaID, Pizza s);

        Pizza getPizza(int pizzaID);

        #endregion

        #region PizzaBase

        void addPizzaBase(PizzaBase d);

        bool delPizzaBase(int PBID);

        void updatePizzaBase(int PBID, PizzaBase s);

        PizzaBase getPizzaBase(int PBID);

        #endregion

        #region PizzaBaseSize

        void addPizzaBaseSize(PizzaBaseSize d);

        bool delPizzaBaseSize(int PBSID);

        void updatePizzaBaseSize(int PBSID, PizzaBaseSize s);

        PizzaBaseSize getPizzaBaseSize(int PBSID);

        #endregion

        #region Rank  

        void addRank(Rank d);

        bool delRank(int rankID);

        void updateRank(int rankID, Rank s);

        Rank getRank(int rankID);

        #endregion

        #region Store

        void addStore(Store d);

        bool delStore(int storeID);

        void updateStore(int storeID, Store s);

        Store getStore(int storeID);

        #endregion

        #region ToppingType

       

        void addToppingType(ToppingType d);

        bool delToppingType(int TTID);

        void updateToppingType(int TTID, ToppingType s);

        ToppingType getToppingType(int TTID);

        #endregion

        #region getLists

        List<Customer> getCustomer();

        List<Dough> getDough();

        List<Employee> getEmployee();

        List<Order> getOrder();

        List<Pizza> getPizza();

        List<PizzaBase> getPizzaBase();

        List<PizzaBaseSize> getPizzaBaseSize();

        List<Rank> getRank();

        List<Store> getStore();

        List<ToppingType> getToppingType();

       

        #endregion

        
    }
}
