import 'package:flutter/material.dart';

class TextEditor extends StatelessWidget {
  final TextEditingController controller;
  final String label;
  final String tip;
  final IconData icon;
  final bool password;
  final int maxLines;

  TextEditor({
    this.controller,
    this.label,
    this.tip,
    this.icon,
    this.password = false,
    this.maxLines = 1,
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: TextFormField(
        maxLines: maxLines,
        obscureText: password,
        controller: controller,
        style: TextStyle(
          fontSize: 16.0,
        ),
        decoration: InputDecoration(
          icon: icon != null ? Icon(icon) : null,
          labelText: label,
          hintText: tip,
        ),
        keyboardType: TextInputType.text,
      ),
    );
  }
}
