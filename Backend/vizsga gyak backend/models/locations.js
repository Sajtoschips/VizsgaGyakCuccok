const { ObjectId } = require('mongoose')
const mongoose = require('mongoose')

const locationSchema = new mongoose.Schema({
	_id: {
		type: Number,
		required: true,
	},
	locationName: {
		type: String,
		required: true,
		unique: true,
		maxlength: [30, 'A név nem tartalmazhat 30 karakternél többet!'],
	},
})

module.exports = mongoose.model('LocationModel', locationSchema, 'locations') 