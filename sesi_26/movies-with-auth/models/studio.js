'use strict'
const { Model } = require('sequelize')

module.exports = (sequelize, DataTypes) => {
  class Studio extends Model {
    static associate(models) {
      this.hasMany(models.Movie)
      this.belongsTo(models.User)
    }
  }

  Studio.init(
    {
      UserId: {
        type: DataTypes.INTEGER,
        references: { model: "Users", key: "id" }
      },
      name: DataTypes.STRING,
      specialization: DataTypes.STRING,
    },
    { sequelize, modelName: 'Studio' }
  )
  
  return Studio
}
