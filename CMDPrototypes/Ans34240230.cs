using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEvenNumbers
{
    public class Ans34240230
    {
        private int breakpoint = 11;
        private List<Item> completList;
        private Dictionary<int, List<Item>> ListSubSets;
        public List<Item> CompleteList => completList;
        public Dictionary<int, List<Item>> Broken => ListSubSets;

        public Ans34240230()
        {
            completList = new List<Item>();
            ListSubSets = new Dictionary<int, List<Item>>();
        }

        public void BreakListUp()
        {
            int counter = 0;
            int index = 0;
            List<Item> Subset = new List<Item>();
            foreach (var item in CompleteList)
            {
                counter++;
                if (counter > breakpoint)//Signal a new subset.
                {
                    ListSubSets.Add(index, Subset);
                    Subset = new List<Item>();
                    index++;
                    counter = 0;
                }
                else
                {
                    Subset.Add(new Item() { Id = item.Id });
                }
            }
            ListSubSets.Add(index, Subset);//Catch leftovers.
        }

        private void BreakList()
        {
            Ans34240230 MainList = new Ans34240230();
            MainList.CompleteList.AddRange(new List<Item> { new Item() { Id = "1" },
                new Item() { Id = "2" },
                new Item() { Id = "3" },
                new Item() { Id = "4" },
                new Item() { Id = "5" },
                new Item() { Id = "6" },
                new Item() { Id = "7" },
                new Item() { Id = "8" },
                new Item() { Id = "9" },
                new Item() { Id = "10" },
                new Item() { Id =  "11" },
                new Item() { Id = "12" },
                new Item() { Id = "13" },
                new Item() { Id = "14" },
                new Item() { Id = "15" },
                new Item() { Id = "16" },
                new Item() { Id = "17" },
                new Item() { Id = "18" },
                new Item() { Id = "19" },
                new Item() { Id = "20" },
                new Item() { Id = "21" },
                new Item() { Id = "22" } });
            MainList.BreakListUp();
            foreach (KeyValuePair<int, List<Item>> kvp in MainList.Broken)
            {
                Console.WriteLine("List: " + kvp.Key);
                foreach (Item Stuff in kvp.Value)
                {
                    Console.WriteLine(Stuff.Id);
                }
                Console.ReadKey();
            }

            List<List<Item>> Chunks = MainList.CompleteList.ChunkBy(11).ToList();
            foreach (List<Item> Chunk in Chunks)
            {
                int counter = 1;
                foreach (Item ChunkItem in Chunk)
                {
                    Console.WriteLine("List: " + counter);
                    Console.WriteLine(ChunkItem.Id);
                    Console.ReadKey();
                    counter++;
                }
            }

            MainList.JustOutputIt(11);
            throw new NotImplementedException();
        }

        public void JustOutputIt(int ChunkSize)
        {
            int counter = 0;
            while (CompleteList.Any())
            {
                List<Item> Chunks = new List<Item>();
                Chunks.AddRange(completList.Take(ChunkSize).ToList());
                Console.WriteLine("List: " + counter);
                foreach (Item ChunkItem in Chunks)
                {
                    Console.WriteLine(ChunkItem.Id);
                }
                completList = completList.Skip(ChunkSize).ToList();
                Console.ReadKey();
                counter++;
            }
        }

        public bool Execute(string[] args)
        {
            bool retValue = false;
            Ans34240230 MainList = new Ans34240230();
            List<Item> Source = new List<Item> { new Item() { Id = "1" },
                new Item() { Id = "2" },
                new Item() { Id = "3" },
                new Item() { Id = "4" },
                new Item() { Id = "5" },
                new Item() { Id = "6" },
                new Item() { Id = "7" },
                new Item() { Id = "8" },
                new Item() { Id = "9" },
                new Item() { Id = "10" },
                new Item() { Id =  "11" },
                new Item() { Id = "12" },
                new Item() { Id = "13" },
                new Item() { Id = "14" },
                new Item() { Id = "15" },
                new Item() { Id = "16" },
                new Item() { Id = "17" },
                new Item() { Id = "18" },
                new Item() { Id = "19" },
                new Item() { Id = "20" },
                new Item() { Id = "21" },
                new Item() { Id = "22" } };
            List<List<Item>> Chunks = new List<List<Item>>();
            Chunks.MakeLittleRocksOutOfABigRock(Source, 11);
            int counter = 1;
            foreach (List<Item> Chunk in Chunks)
            {
                Console.WriteLine("List: " + counter);
                foreach (Item ChunkItem in Chunk)
                {
                    Console.WriteLine(ChunkItem.Id);
                }
                Console.ReadKey();
                counter++;
            }
            return retValue;
        }
    }

    public class Item
    {
        public string Id { get; set; }
        public Item()
        {

        }
        public Item(Item itm)
        {
            this.Id = itm.Id;
        }
    }
    public static class ListExtensionMethods
    {
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
        public static List<List<T>> MakeLittleRocksOutOfABigRock<T>(this List<List<T>> Instance, List<T> source, int chunkSize)
        {
            List<Object> CurrentChunk = Instance.LastOrDefault() as List<Object>;
            if (CurrentChunk == null)
            {
                CurrentChunk = new List<Object>();
            }
            int count = CurrentChunk.Count;
            if (count > chunkSize)
            {
                CurrentChunk = new List<Object>();
            }
            int index = 0;
            foreach (var sourceItem in source)
            {
                if (index < (chunkSize - 1))
                {
                    CurrentChunk.Add((T)Activator.CreateInstance(typeof(T), new object[] { (T)sourceItem }));
                }
                else
                {
                    CurrentChunk.Add((T)Activator.CreateInstance(typeof(T), new object[] { (T)sourceItem }));
                    Instance.Add(CurrentChunk.ConvertAll<T>( var => (T)Activator.CreateInstance(typeof(T), new object[] { (T)var })));
                    CurrentChunk = new List<Object>();
                    index = 0;
                }
                index++;
            }
            if (CurrentChunk.Count > 0)
            {
                Instance.Last().AddRange(CurrentChunk.ConvertAll<T>(var => (T)Activator.CreateInstance(typeof(T), new object[] { (T)var })));//Pickup the slack.
            }
            return Instance;
        }
    }
}
