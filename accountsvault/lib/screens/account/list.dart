/*
import 'package:flutter/material.dart';

class SearchList extends StatefulWidget {
  SearchList({Key key}) : super(key: key);
  @override
  _SearchListState createState() => new _SearchListState();
}

class _SearchListState extends State<SearchList> {
  Widget appBarTitle = new Text(
    "Search Sample",
    style: new TextStyle(color: Colors.white),
  );
  Icon actionIcon = new Icon(
    Icons.search,
    color: Colors.white,
  );
  final key = new GlobalKey<ScaffoldState>();
  final TextEditingController _searchQuery = new TextEditingController();
  List<String> _list;
  bool _IsSearching;
  String _searchText = "";

  _SearchListState() {
    _searchQuery.addListener(() {
      if (_searchQuery.text.isEmpty) {
        setState(() {
          _IsSearching = false;
          _searchText = "";
        });
      } else {
        setState(() {
          _IsSearching = true;
          _searchText = _searchQuery.text;
        });
      }
    });
  }

  @override
  void initState() {
    super.initState();
    _IsSearching = false;
    init();
  }

  void init() {
    _list = List();
    _list.add("Google");
    _list.add("IOS");
    _list.add("Andorid");
    _list.add("Dart");
    _list.add("Flutter");
    _list.add("Python");
    _list.add("React");
    _list.add("Xamarin");
    _list.add("Kotlin");
    _list.add("Java");
    _list.add("RxAndroid");
  }

  @override
  Widget build(BuildContext context) {
    return new Scaffold(
      key: key,
      appBar: buildBar(context),
      body: new ListView(
        padding: new EdgeInsets.symmetric(vertical: 8.0),
        children: _IsSearching ? _buildSearchList() : _buildList(),
      ),
    );
  }

  List<ChildItem> _buildList() {
    return _list.map((contact) => new ChildItem(contact)).toList();
  }

  List<ChildItem> _buildSearchList() {
    if (_searchText.isEmpty) {
      return _list.map((contact) => new ChildItem(contact)).toList();
    } else {
      List<String> _searchList = List();
      for (int i = 0; i < _list.length; i++) {
        String name = _list.elementAt(i);
        if (name.toLowerCase().contains(_searchText.toLowerCase())) {
          _searchList.add(name);
        }
      }
      return _searchList.map((contact) => new ChildItem(contact)).toList();
    }
  }

  Widget buildBar(BuildContext context) {
    return new AppBar(centerTitle: true, title: appBarTitle, actions: <Widget>[
      new IconButton(
        icon: actionIcon,
        onPressed: () {
          setState(() {
            if (this.actionIcon.icon == Icons.search) {
              this.actionIcon = new Icon(
                Icons.close,
                color: Colors.white,
              );
              this.appBarTitle = new TextField(
                controller: _searchQuery,
                style: new TextStyle(
                  color: Colors.white,
                ),
                decoration: new InputDecoration(
                    prefixIcon: new Icon(Icons.search, color: Colors.white),
                    hintText: "Search...",
                    hintStyle: new TextStyle(color: Colors.white)),
              );
              _handleSearchStart();
            } else {
              _handleSearchEnd();
            }
          });
        },
      ),
    ]);
  }

  void _handleSearchStart() {
    setState(() {
      _IsSearching = true;
    });
  }

  void _handleSearchEnd() {
    setState(() {
      this.actionIcon = new Icon(
        Icons.search,
        color: Colors.white,
      );
      this.appBarTitle = new Text(
        "Search Sample",
        style: new TextStyle(color: Colors.white),
      );
      _IsSearching = false;
      _searchQuery.clear();
    });
  }
}

class ChildItem extends StatelessWidget {
  final String name;
  ChildItem(this.name);
  @override
  Widget build(BuildContext context) {
    return new ListTile(title: new Text(this.name));
  }
}
*/

import 'package:accountsvault/componentes/MessageDialog.dart';
import 'package:accountsvault/database/dao/Account.dart';
import 'package:accountsvault/models/Account.dart';
import 'package:accountsvault/screens/Selic.dart';
import 'package:accountsvault/screens/account/AccountItem.dart';
import 'package:accountsvault/screens/account/Form.dart';
import 'package:accountsvault/Constants.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class ListAccounts extends StatefulWidget {
  @override
  State<StatefulWidget> createState() {
    return ListAccountsState();
  }
}

class ListAccountsState extends State<ListAccounts> {
  final AccountDao _dao = AccountDao();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: _showMenu(),
      appBar: AppBar(
        title: Text(Constants.titleAppBarAccounts),
        actions: <Widget>[
          IconButton(
            icon: Icon(Icons.search),
            onPressed: () {
              setState(
                () {},
              );
            },
          ),
        ],
      ),
      body: FutureBuilder<List<Account>>(
        initialData: List(),
        future: _dao.findAll(),
        builder: (contexto, snapshot) {
          switch (snapshot.connectionState) {
            case ConnectionState.none:
              break;
            case ConnectionState.waiting:
              return Center(
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: <Widget>[
                    CircularProgressIndicator(),
                    Text(Constants.loading),
                  ],
                ),
              );
              break;
            case ConnectionState.active:
              break;
            case ConnectionState.done:
              final List<Account> accounts = snapshot.data
                  .where((food) => food.name.toLowerCase().contains('br'))
                  .toList();
              accounts.sort(
                (a, b) {
                  return a.name.toLowerCase().compareTo(b.name.toLowerCase());
                },
              );
              return ListView.builder(
                itemBuilder: (context, index) {
                  final Account account = accounts[index];
                  return Dismissible(
                    key: Key(account.id.toString()),
                    onDismissed: (direction) {
                      setState(() {
                        _dao.delete(account.id);
                        snapshot.data.remove(account);
                      });
                      var accountNameDeleted = account.name;
                      Scaffold.of(context).showSnackBar(
                        SnackBar(
                          content: Text(
                            '$accountNameDeleted deleted.',
                            style: TextStyle(color: Colors.white),
                          ),
                          backgroundColor: Colors.grey.shade900,
                          action: SnackBarAction(
                            label: Constants.undo,
                            textColor: Constants.colorApp,
                            onPressed: () {
                              _dao.save(account);
                              setState(() {
                                accounts.add(account);
                              });
                            },
                          ),
                        ),
                      );
                    },
                    background: Container(color: Colors.grey.shade800),
                    child: AccountItem(account),
                  );
                },
                itemCount: accounts.length,
              );
              break;
          }
          return Text(Constants.unknownError);
        },
      ),
      floatingActionButton: FloatingActionButton(
        child: Icon(Icons.add),
        onPressed: () {
          Navigator.of(context).push(
            MaterialPageRoute(builder: (context) {
              return AccountForm(null);
            }),
          );
        },
      ),
    );
  }

  Drawer _showMenu() {
    return Drawer(
      child: ListView(
        // Important: Remove any padding from the ListView.
        padding: EdgeInsets.zero,
        children: <Widget>[
          DrawerHeader(
            child: Text('Drawer Header'),
            decoration: BoxDecoration(
              color: Colors.blue,
            ),
          ),
          ListTile(
            title: Text(Constants.titleAppBarAccounts),
            onTap: () {
              Navigator.pop(context);
            },
          ),
          ListTile(
            title: Text(Constants.titleAppBarSelic),
            onTap: () {
              Navigator.of(context).push(
                MaterialPageRoute(
                  builder: (context) {
                    return SelicView();
                  },
                ),
              );
            },
          ),
          ListTile(
            title: Text(Constants.about),
            onTap: () {
              showDialog(
                context: context,
                builder: (BuildContext context) {
                  return MessageDialog(
                    title: Constants.about,
                    content: Constants.version,
                    textCloseButton: Constants.close,
                  );
                },
              );
            },
          ),
        ],
      ),
    );
  }
}
