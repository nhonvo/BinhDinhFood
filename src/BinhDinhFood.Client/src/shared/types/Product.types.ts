import { TReview } from './Review.types'

export interface IProduct {
  _id: string // TODO: CHANGE ID TO _ID
  brand: TBrand // hidden not has plan
  type: TType // hidden not has plan
  offPrice: number
  gender: TGender // remove
  color: string[] // hidden
  size: string[] // hidden
  slug: string // remove
  gallery: string[]
  poster?: string
  detail_product?: TDetailProduct[]
  // new
  name: string;
  price: number;
  description: string | null;// remove
  amount: number | null; // -> quantity
  discount: number | null; //-> off price
  rating: number | null;
  image: string | null;
  dateCreated: string | null; // remove
  category: string[] | null; // remove
  reviews: ReviewResponse[]; // remove
}

export interface ReviewResponse {
  id: number | null;
  rating: number | null;
  comment: string | null;
  dateCreated: string | null;
}
// remove 
export type TBrand = 'nike' | 'adidas' | 'jordan' | 'puma'

// remove 
export type TType = 'football' | 'basketball'

// remove 
export type TGender = 'men' | 'women' | 'kid'

export type Price = {
  minPrice: number
  maxPrice: number
}

export type TSort = 'relevance' | 'new arrivals' | 'price:low' | 'price:high'

export type TDetailProduct = {
  title: string
  description?: string
  specification?: string[]
}

export type TProductRequest = string

export type TProductResponse = {
  error: boolean
  product: IProduct
  reviews: TReview[]
}

export type TSearchResponse = {
  products: IProduct[]
  suggestions: string[]
}

// new
// TODO: move utilizes method
export type Paging<T> = {
  totalPages: number;
  pageSize: number;
  totalItemsCount: number;
  currentPage: number;
  next: boolean;
  previous: boolean;
  items: T[];
}

export type TProductsResponse = Paging<IProduct>;

// TODO: move utilizes method
export type TProductErrorResponse = {
  errorCode: string
  message: string
}

export type TSearchRequest = string
