#include <stdlib.h>
#include <stdbool.h>
GtkBuilder *builder;
GtkWidget *windows;

void on_sistema_petshop_destroy(GtkWidget *Widget, gpointer data){

    gtk_main_quit();
    }

int main (int argc, char *argv[]){
    gtk_init(&argc, &argv);
    GtkBuilder *builder = gtk_builder_new_from_file("ui.glade");
    gtk_builder_add_callback_symbols(
        builder,
        "on_sistema_petshop_destroy",                    G_CALLBACK(on_sistema_petshop_destroy),
        "on_login_button_clicked",                       G_CALLBACK(on_login_button_clicked),
        "on_inicial_cad_button_clicked",                 G_CALLBACK(on_inicial_cad_button_clicked),
        "on_inicial_agen_button_clicked",                G_CALLBACK(on_inicial_agen_button_clicked),
        "on_inicial_prod_button_clicked",                G_CALLBACK(on_inicial_prod_button_clicked),
        NULL);
    gtk_builder_connect_signals(builder, NULL);
    window = GTK_WIDGET(gtk_builder_get_object(builder, "on_sistema_petshop"));

}
