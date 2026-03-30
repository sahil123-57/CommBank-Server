const mongoose = require('mongoose');

// Define the Goal Schema based on the provided technical models 
const goalSchema = new mongoose.Schema({
  name: {
    type: String,
    required: true // Based on source [cite: 7, 8]
  },
  targetAmount: {
    type: Number,
    required: true // Based on source [cite: 9, 11]
  },
  targetDate: {
    type: Date,
    required: true // Based on source [cite: 12, 15]
  },
  balance: {
    type: Number,
    default: 0 // Based on source [cite: 17, 18]
  },
  // This is the specific modification requested by the task
  icon: {
    type: String,
    required: false // Optional public field as per task instructions
  },
  userId: {
    type: mongoose.Schema.Types.ObjectId,
    ref: 'User',
    required: true // Links to the User table [cite: 1, 31]
  }
}, {
  timestamps: true // Standard practice for tracking creation/updates
});

module.exports = mongoose.model('Goal', goalSchema);
