
namespace Blackjack.Data
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Hand CurrentHand { get; set; }
        public float Cash { get; set; }
    }
}
