using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongCollectionAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate.ValueObjects;

namespace Sympho.Core.Domain.UserAggregate.Entities
{
    public sealed class Creator : Entity<CreatorId> {

        private readonly List<RecordLabel> _labels;
        private readonly List<DateRange> _yearsActive;
        private readonly List<SongCollectionId> _songCollectionIds;
        private readonly List<ListenerId> _listenerIds;

        public string StageName { get; private set; }
        public Origin Origin { get; private set; }
        public IReadOnlyList<RecordLabel> Labels => _labels.AsReadOnly();
        public IReadOnlyList<DateRange> YearsActive => _yearsActive.AsReadOnly();
        public IReadOnlyList<SongCollectionId> SongCollectionIds => _songCollectionIds.AsReadOnly();
        public IReadOnlyList<ListenerId> ListenerIds => _listenerIds.AsReadOnly();
        public string ImgUrl1 { get; private set; }
        public string ImgUrl2 { get; private set; }

        private Creator(
            CreatorId id,
            string stageName,
            Origin origin,
            List<RecordLabel> labels,
            List<DateRange> yearsActive,
            List<SongCollectionId> songCollectionIds,
            List<ListenerId> listenerIds,
            string imgUrl1,
            string imgUrl2) : base(id){

            StageName = stageName;
            Origin = origin;
            _labels = labels;
            _yearsActive = yearsActive;
            _songCollectionIds = songCollectionIds;
            _listenerIds = listenerIds;
            ImgUrl1 = imgUrl1;  
            ImgUrl2 = imgUrl2;
        }

        public static Creator Create(
            string stageName,
            Origin origin,
            List<RecordLabel>? labels,
            List<DateRange>? yearsActive,
            List<SongCollectionId>? songCollectionIds,
            List<ListenerId>? listenerIds,
            string imgUrl1,
            string imgUrl2) {

            return new Creator(
                CreatorId.CreateUnique(),
                stageName,
                origin,
                labels ?? new(),
                yearsActive ?? new(),
                songCollectionIds ?? new(),
                listenerIds ?? new(),
                imgUrl1,
                imgUrl2);
        }

    }
}
