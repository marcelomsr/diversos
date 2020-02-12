import 'package:flutter/material.dart';

class Editor extends StatelessWidget {
  final String text;
  final TextEditingController controller;
  final String label;
  final String tip;
  final IconData icon;

  Editor({
    this.text,
    this.controller,
    this.label,
    this.tip,
    this.icon,
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: TextFormField(
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
