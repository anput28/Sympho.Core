namespace Sympho.Core.Domain.Common.Models {

    /*
     * IEquatable si implementa per gli oggetti che potrebbero far parte di una collezione,
     * poichè le collezioni la utilizzano per questioni di performance all'interno dei loro metodi.
     * 
     * Al fine di rendere consistente il comportamento del metodo Equals(T) di IEquatable e quello
     * del metodo Equals(Object) della classe Object, bisogna fare l'override anche di quest'ultimo
     * e del metodo GetHashCode().
     */
    public abstract class Entity<TId> : IEquatable<Entity<TId>> where TId: notnull {

        public TId Id { get; protected set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }

        public Entity(TId id) {
           Id = id;
           CreatedDateTime = DateTime.UtcNow;
           UpdatedDateTime = DateTime.UtcNow;
        }

        // Rewrites the method to determine the equality of two instances
        public override bool Equals(object? obj) {
            return obj is Entity<TId> entity && Id.Equals(entity.Id);
        }

        // IEquatable interface method
        // Calls the Equals() method rewritten above to enforce equality
        public bool Equals(Entity<TId>? other) {
            return Equals((object?)other);
        }

        public static bool operator ==(Entity<TId> left, Entity<TId> right) {
            return Equals(left, right);
        }

        public static bool operator !=(Entity<TId> left, Entity<TId> right) {
            return !Equals(left, right);
        }

        public override int GetHashCode() {
            return Id.GetHashCode();
        }
    }
}
