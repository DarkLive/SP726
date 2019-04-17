package com.example.kotlin01

import android.os.Bundle
import android.support.v7.app.AppCompatActivity
import kotlinx.android.synthetic.main.activity_main.*

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        btnplus.setOnClickListener { doMath('+') }
        btnminus.setOnClickListener { doMath('-') }
        btnmultiply.setOnClickListener { doMath('*') }
        btndivide.setOnClickListener { doMath('/') }
    }

    private fun doMath(operation: Char) {
        if (operation == '/' && (num1.text.toString() == "0" || num2.text.toString() == "0")) {
            output.text = "Cant divide by 0"; return
        }
        when (operation) {
            '+' -> output.text =
                "${num1.text} + ${num2.text} = ${num1.text.toString().toInt() + num2.text.toString().toInt()}"
            '-' -> output.text =
                "${num1.text} - ${num2.text} = ${num1.text.toString().toInt() - num2.text.toString().toInt()}"
            '*' -> output.text =
                "${num1.text} * ${num2.text} = ${num1.text.toString().toInt() * num2.text.toString().toInt()}"
            '/' -> output.text =
                "${num1.text} / ${num2.text} = ${num1.text.toString().toInt() / num2.text.toString().toInt()}"
        }
    }
}
