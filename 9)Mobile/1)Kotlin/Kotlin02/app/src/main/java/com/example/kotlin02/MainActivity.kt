package com.example.kotlin02

import android.support.v7.app.AppCompatActivity
import android.os.Bundle
import android.provider.Telephony
import android.widget.Toast
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        btnget.setOnClickListener { doStuff(radioGroup.checkedRadioButtonId) }
    }

    private fun doStuff(which: Int){
        if (weight.text.toString().toFloatOrNull() == null) { Toast.makeText(this,"Please enter a number before clicking the button",Toast.LENGTH_SHORT).show(); return }
        when (which){
            R.id.r1 -> doStuffToasty("Mercury", weight.text.toString().toFloat() * 0.377f)
            R.id.r2 -> doStuffToasty("Venus", weight.text.toString().toFloat() * 0.904f)
            R.id.r3 -> doStuffToasty("Earth", weight.text.toString().toFloat() * 1f)
            R.id.r4 -> doStuffToasty("Mars", weight.text.toString().toFloat() * 0.38f)
            R.id.r5 -> doStuffToasty("Jupiter", weight.text.toString().toFloat() * 2.53f)
            R.id.r6 -> doStuffToasty("Saturn", weight.text.toString().toFloat() * 1.065f)
            R.id.r7 -> doStuffToasty("Uranus", weight.text.toString().toFloat() * 0.886f)
            R.id.r8 -> doStuffToasty("Neptune", weight.text.toString().toFloat() * 1.14f)
            R.id.r9 -> doStuffToasty("Pluto", weight.text.toString().toFloat() * 0.063f)
        }
    }

    private fun doStuffToasty(planet: String, weight: Float){
        Toast.makeText( this, "Your Weight in $planet is ${String.format("%.2f",weight)}", Toast.LENGTH_SHORT).show()
    }
}
