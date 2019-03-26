using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ordenamiento.Pruebas
{
   
   
    public class pruebasOrdenamiento
    {
        private int[] salidaEsperada=new int[] {1,2,3,4,5};
        private int[] salidaEsperada2=new int[] {1,1,1,1,1};
        private int[] salidaEsperada3=new int[] {1,4,3,4,2};
        private ordenamiento.Burbuja ordenar = new ordenamiento.Burbuja();
        
        public void TestInvertido()
        {
            //entradas
            int[]entrada = new int[] {5,4,3,2,1};
            //proceso
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        public void TestOrdenado()
        {
            //entradas
            int[]entrada = new int[] {1,2,3,4,5};
            //proceso
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        public void TestUnos()
        {
            //entradas
            int[]entrada = new int[] {1,1,1,1,1};
            //proceso
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada2, entrada);
        }
    }
}
