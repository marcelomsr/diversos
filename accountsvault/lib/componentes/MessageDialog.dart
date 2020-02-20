import 'package:accountsvault/Constants.dart';
import 'package:flutter/material.dart';

class MessageDialog extends StatelessWidget {
  final String title;
  final String content;
  final String textCloseButton;

  MessageDialog({
    this.title,
    this.content,
    this.textCloseButton,
  });

  @override
  Widget build(BuildContext context) {
    return AlertDialog(
      shape: RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(10.0),
      ),
      title: Text(title),
      content: Text(content),
      actions: textCloseButton != null ? actions(context) : null,
    );
  }

  List<Widget> actions(BuildContext context) {
    return <Widget>[
      FlatButton(
        child: Text(Constants.close),
        onPressed: () {
          Navigator.of(context).pop();
        },
      )
    ];
  }
}
