using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Model.Entities;

[Table("STOCKS")]
[NotMapped]
public class Stock{

    [JsonProperty("date")]
    [Column("DATE",TypeName = "DATE")]
    [NotMapped]
    public DateTime Date{ get; set; }
    
    [JsonProperty("open")]
    [Column("OPEN",TypeName = "DOUBLE")]
    [NotMapped]
    public double Open{ get; set; }
    
    [JsonProperty("close")]
    [Column("CLOSE",TypeName = "DOUBLE")]
    [NotMapped]
    public double Close{ get; set; }
    
    [JsonProperty("high")]
    [Column("HIGH",TypeName = "DOUBLE")]
    [NotMapped]
    public double High{ get; set; }
    
    [JsonProperty("low")]
    [Column("LOW",TypeName = "DOUBLE")]
    [NotMapped]
    public double Low{ get; set; }
    
    [JsonProperty("volume")]
    [Column("VOLUME")]
    [NotMapped]
    public int Volume{ get; set; }
    
    [JsonProperty("adjOpen")]
    [Column("ADJ_OPEN",TypeName = "DOUBLE")]
    [NotMapped]
    public double AdjOpen{ get; set; }
    
    [JsonProperty("adjClose")]
    [Column("ADJ_CLOSE",TypeName = "DOUBLE")]
    [NotMapped]
    public double AdjClose{ get; set; }
    
    [JsonProperty("adjHigh")]
    [Column("ADJ_HIGH",TypeName = "DOUBLE")]
    [NotMapped]
    public double AdjHigh{ get; set; }
    
    [JsonProperty("adjLow")]
    [Column("ADJ_LOW",TypeName = "DOUBLE")]
    [NotMapped]
    public double AdjLow{ get; set; }
    
    [JsonProperty("adjVolume")]
    [Column("ADJ_VOLUME")]
    [NotMapped]
    public Int64 AdjVolume{ get; set; }
    
    [JsonProperty("divCash")]
    [Column("DIV_CASH",TypeName = "DOUBLE")]
    [NotMapped]
    public double DivCash{ get; set; }
    
    [JsonProperty("splitFactor")]
    [Column("SPLIT",TypeName = "DOUBLE")]
    [NotMapped]
    public double Split{ get; set; }

    public override string ToString(){
        return $"Date: {Date}, Open: {Open}, Close: {Close}, High: {High}, Low: {Low}, Volume: {Volume}, AdjOpen: {AdjOpen}, AdjClose: {AdjClose}, AdjHigh: {AdjHigh}, AdjLow: {AdjLow}, AdjVolume: {AdjVolume}, DivCash: {DivCash}, Split: {Split}";
    }
}