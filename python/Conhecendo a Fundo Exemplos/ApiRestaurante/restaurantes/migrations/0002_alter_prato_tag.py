# Generated by Django 3.2.10 on 2022-01-05 20:03

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('restaurantes', '0001_initial'),
    ]

    operations = [
        migrations.AlterField(
            model_name='prato',
            name='tag',
            field=models.CharField(choices=[('Doces', 'Doces'), ('Caldos', 'Caldos'), ('Americana', 'Americana'), ('Baiana', 'Baiana'), ('Coreana', 'Coreana'), ('Espanhola', 'Espanhola'), ('Francesa', 'Francesa'), ('Italiana', 'Italiana'), ('Japonesa', 'Japonesa'), ('Mexicana', 'Mexicana'), ('Mineira', 'Mineira'), ('Vegetariana', 'Vegetariana'), ('Massas', 'Massas'), ('Molhos', 'Molhos'), ('Salada', 'Salada'), ('Light', 'Light')], default='-', max_length=15),
        ),
    ]
