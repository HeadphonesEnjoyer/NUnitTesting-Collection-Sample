using Collections;

namespace Collection.UnitTests
{
    public class CollectionTests
    {


        [Test]
        public void Test_Collection_EmptyConstructor()
        {

            //Arrange & Act
            var coll = new Collection<int>();

            //Assert

            Assert.AreEqual(coll.ToString(), "[]");

            Assert.AreEqual(coll.Count, 0);
            Assert.AreEqual(coll.Capacity, 16);

        }
        [Test]

        public void Test_Collection_ConstructorSingleItem()
        {

            var coll = new Collection<int>(5);

            var actual = coll.ToString();
            var expected = "[5]";

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Collection_ConstructorMultipleItems()
        {

            var coll = new Collection<int>(5, 6);

            Assert.AreEqual(coll.ToString(), "[5, 6]");
        }

        [Test]
        public void Test_Collection_CountAndCapacity()
        {

            var coll = new Collection<int>(5, 6);

            Assert.AreEqual(coll.Count, 2, "Check for count");
            Assert.That(coll.Capacity, Is.GreaterThan(coll.Count));

        }

        [Test]

        public void Test_Collection_Add()
        {
            //Arrange
            var coll = new Collection<string>("Ivan", "Petar");

            //Act
            coll.Add("Gosho");

            //Assert

            Assert.AreEqual(coll.ToString(), "[Ivan, Petar, Gosho]");

        }

        [Test]

        public void Test_Collection_GetByIndex()
        {

            var collection = new Collection<int>(5, 6, 7);
            var item = collection[1];

            Assert.That(item.ToString(), Is.EqualTo("6"));


        }

        [Test]

        public void Test_Collection_SetByIndex()
        {

            var collection = new Collection<int>(5, 6, 7);
            var item = collection[1] = 666;

            Assert.That(collection.ToString(), Is.EqualTo("[5, 666, 7]"));

        }

        [Test]
        public void Test_Collection_GetByInvalidIndex() 
        
            {
            //Arrange
            var coll = new Collection<string>("Ivan", "Petar");

            Assert.That(() => { var item = coll[1]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());

        }

    }
}