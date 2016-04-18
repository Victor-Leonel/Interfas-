using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IImprimible
{
    void Imprime();
    void Imprime(int n);
}

    class Usuario: IComparable,IImprimible
    {
        public string nombre, correo;
        public Usuario(string n, string c)
        {
            this.nombre = n;
            this.correo = c;
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}",this.nombre, this.correo);
        }

        public int CompareTo(object o)
        {
            /* Es otra forma de poner el siguiente linea de codigo
                Usuario usr = (Usuario o)
                 return this.nombre.CompareTo( usr.nombre );
            */
            return this.nombre.CompareTo( ((Usuario) o).nombre );
        }

    public void Imprime()
    {
        throw new NotImplementedException();
    }

    public void Imprime(int n)
    {
        throw new NotImplementedException();
    }
}

    class progam
    {
        static private List<Usuario> usuarios = new List<Usuario>();
        static void Main(string[] args)
        {
            usuarios.Add(new Usuario("ana     ", " ana@gmail.com"));
            usuarios.Add(new Usuario("VL      ", " vlab.134031@gmail.com"));
            usuarios.Add(new Usuario("Tana    ", " Tana@gmail.com"));
            usuarios.Add(new Usuario("Brissa  ", " Brissa@gmail.com"));
            usuarios.Add(new Usuario("Electra ", " Electra@gmail.com"));
            usuarios.Add(new Usuario("Drago   ", " Drago@gmail.com"));

            Console.WriteLine("Desordenados");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }

            usuarios.Sort();
            Console.WriteLine("Ordenados");
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine(u);
            }
            Console.ReadKey();
        }

    }

