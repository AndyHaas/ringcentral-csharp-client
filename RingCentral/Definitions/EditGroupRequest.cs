namespace RingCentral
{
    public partial class EditGroupRequest
    {
        // List of users to be added to a team
        public string[] @addedExtensionIds { get; set; }
        // List of users to be removed from a team
        public string[] @removedExtensionIds { get; set; }
    }
}
