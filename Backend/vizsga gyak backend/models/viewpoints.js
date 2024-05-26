const mongoose = require('mongoose')

const viewpointsSchema = new mongoose.Schema({
  _id: {
    type: Number,
    required: true,
  },
  viewpointName: {
    type: String,
    required: true,
    unique: true,
    maxlength: [50, 'A név nem tartalmazhat 30 karakternél többet!'],
  },
  mountain: {
    type: String,
    unique: true,
    required: true,
    maxlength: [50, 'A név nem tartalmazhat 30 karakternél többet!'],
  },
  location: {
    type: String,
    required: true,
    ref: 'LocationModel',
  },
  height: {
    type: Number,
    min: [1, 'Egy kilátónak legalább 1 méter magasnak kell lennie!'],
  },
  description: {
    type: String,
    required: true,
  },
  built: {
    type: Date,
    max: [Date.now, 'Az aktuális dátumnál nem adhat meg későbbi dátumot a built mezőben!'],
  },
  imageUrl: {
    type: String,
    unique: true,
    required: true,
    maxlength: [50, 'A név nem tartalmazhat 30 karakternél többet!'],
    default: ["http://elit.jedlik.eu/viewpoints/no-img.jpg"]
  },
})

module.exports = mongoose.model('viewpointsModel', viewpointsSchema, 'viewpoints')
