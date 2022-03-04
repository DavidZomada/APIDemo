using System;
namespace APIDemo.Models {
  public class Plant {

    public int PlantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }

    public Plant() {
    }

    public Plant(int PlantId, string Name, string Description, string Picture) {
      this.PlantId = PlantId;
      this.Name = Name;
      this.Description = Description;
      this.Picture = Picture;
    }
  }
}
