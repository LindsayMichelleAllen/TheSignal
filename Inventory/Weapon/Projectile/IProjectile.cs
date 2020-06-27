public interface IProjectile : IWeapon
{
    float range {get; set;}
    float fire();
}
