import { Component, OnInit, computed, signal } from '@angular/core';
import { Item } from '../../models/item.model';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-shop-cart',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './shop-cart.component.html',
  styleUrl: './shop-cart.component.scss'
})
export class ShopCartComponent {
  products: Array<any> = [
    {
      id: 1,
      name: "Camiseta Branca",
      price: 25.99,
      imgURL: "https://cdn.iset.io/assets/51664/produtos/143/camiseta-teste-2.png"
    },
    {
      id: 2,
      name: "Calça Jeans",
      price: 39.99,
      imgURL: "https://images.tcdn.com.br/img/img_prod/989359/calca_jeans_masculina_paiol_country_tradicional_14440_1_2395_1_a9c83ac89a85b6492470512fbfc2f7b1.jpg"
    },
    {
      id: 3,
      name: "Tênis Preto",
      price: 49.99,
      imgURL: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTvWH7HhIQSGfwI7jk4ZjP_nJKnIRwLyZQwCKFGHMMtw&s"
    },
    {
      id: 4,
      name: "Jaqueta de Couro",
      price: 79.99,
      imgURL: "https://www.omk.com.br/media/catalog/product/cache/1/image/800x/9df78eab33525d08d6e5fb8d27136e95/1/8/18195680_10210572461722634_1381412086_o_1_1.jpg"
    },
    {
      id: 5,
      name: "Saia Floral",
      price: 29.99,
      imgURL: "https://s.pksstore.com.br/catalog/product/cache/1/image/2000x3000/9df78eab33525d08d6e5fb8d27136e95/s/a/saia_midi_evase_preta_pks.jpg"
    },
    {
      id: 6,
      name: "Blusa Listrada",
      price: 19.99,
      imgURL: "https://tfcra5.vteximg.com.br/arquivos/ids/188337/blusa-listrada-malha-lurex-preto-60076.jpg?v=637747411088670000"
    },
    {
      id: 7,
      name: "Shorts Jeans",
      price: 24.99,
      imgURL: "https://img.elo7.com.br/product/zoom/331188B/shorts-jeans-feminino-customizado-shorts-jeans.jpg"
    },
    {
      id: 8,
      name: "Moletom Cinza",
      price: 34.99,
      imgURL: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9Z0alOdI3ZMOqbfmt5uxO638gdy1aBJHexaM8ayOROA&s"
    },
    {
      id: 9,
      name: "Bolsa de Couro",
      price: 59.99,
      imgURL: "https://cdn.awsli.com.br/600x450/485/485894/produto/48612503c4a4e088ff.jpg"
    },
    {
      id: 10,
      name: "Chapéu de Palha",
      price: 14.99,
      imgURL: "https://www.atacadaodaindustria.com.br/wp-content/uploads/2021/10/chapeu-de-palha-caranda-frente.jpg"
    }
  ];

  cart = signal<Item[]>([]);

  precoTotal = computed(() => {
    return this.cart().reduce((acc, item) => acc + (item.price * item.quantity), 0);
  });

  addItem(product: any) {
    let productIsAlreadyInCart = this.cart().some(
      item => item.id === product.id
    )

    console.log(productIsAlreadyInCart)

    if (!productIsAlreadyInCart) {
      this.cart.update(values => [...values, { ...product, quantity: 1 }]);
    } else {
      this.cart.set(this.cart().map(item =>
        item.id === product.id
          ? { ...item, quantity: item.quantity + 1 }
          : item
      ));
    }
  }

  removeItem(id: any) {
    this.cart.set(this.cart().filter((item) => item.id !== id));
  }
}
