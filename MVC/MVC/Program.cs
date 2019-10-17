using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal interface IModel
    {
        void SetAdapter(IModelController controler);

        object M(object model);
    }

    internal interface IView
    {
        void SetAdapter(IViewController controller);

        void V();
    }

    internal interface IViewController
    {
        object M(object m);
    }

    internal interface IModelController
    {
        void V();
    }

    internal delegate IModel ModelFactory();

    internal delegate IView ViewFactory();

    internal class Model : IModel
    {
        private IModelController controller;

        public object M(object model)
        {
            return "*" + (string)model + "*";
        }

        public void SetAdapter(IModelController controler)
        {
            this.controller = controler;
        }
    }

    internal class HashModel : IModel
    {
        private IModelController controller;

        public object M(object model)
        {
            return "#" + (string)model + "#";
        }

        public void SetAdapter(IModelController controler)
        {
            this.controller = controler;
        }
    }

    internal class View : IView
    {
        private IViewController controller;

        public void SetAdapter(IViewController controller)
        {
            this.controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Iveskite savo varda");
            var data = Console.ReadLine();
            Console.WriteLine((string)controller.M(data));
        }
    }

    internal class EnglishView : IView
    {
        private IViewController controller;

        public void SetAdapter(IViewController controller)
        {
            this.controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Write your name");
            var data = Console.ReadLine();
            Console.WriteLine((string)controller.M(data));
        }
    }

    internal class Controller : IModelController, IViewController
    {
        private IModel modelis;
        private IView view;

        public Controller(ModelFactory m, ViewFactory v)
        {
            modelis = m();
            view = v();
            modelis.SetAdapter(this);
            view.SetAdapter(this);
        }

        public object M(object m)
        {
            return modelis.M(m);
        }

        public void V()
        {
            view.V();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Anglu kalba 1, Lietuviu kalba 2");
            var data = Console.ReadLine();
            switch (data)
            {
                case "1":
                    Controller c = new Controller(ModelMEthodFactory, EnglishMethdFactory);
                    c.V();
                    break;

                case "2":
                    Controller cont = new Controller(HashMethodFactory, ViewMethodFactory);
                    cont.V();
                    break;

                default:
                    break;
            }
        }

        private static IView EnglishMethdFactory()
        {
            return new EnglishView();
        }

        private static IModel ModelMEthodFactory()
        {
            return new Model();
        }

        private static IView ViewMethodFactory()
        {
            return new View();
        }

        private static IModel HashMethodFactory()
        {
            return new HashModel();
        }
    }
}