namespace Server.Items.Holiday
{
    public class PaintedEvilClownMask : BasePaintedMask
    {
        [Constructable]
        public PaintedEvilClownMask()
            : base(0x4a90)
        {
        }

        public PaintedEvilClownMask(Serial serial)
            : base(serial)
        {
        }

        public override string MaskName => "Evil Clown Mask";
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}