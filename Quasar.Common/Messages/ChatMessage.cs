using ProtoBuf;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class ChatMessage : IMessage
    {
        [ProtoMember(1)]
        public bool FromClient { get; set; }

        [ProtoMember(2)]
        public string Text { get; set; }
    }
}
