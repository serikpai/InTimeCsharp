namespace Kukshaus.InTime.CrossCutting.DataClasses.Entities
{
    public class Attachment : ILocalEntity
    {
        public AttachementId Id { get; set; }
    }

    public class AttachementId : IValueObject
    {
    }
}