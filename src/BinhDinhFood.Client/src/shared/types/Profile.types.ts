export interface IProfile {
  firstName?: string
  lastName?: string
  contactEmail?: string
  phoneNumber?: string
  saveAddress?: boolean
  createdAt?: Date
  address?: string
  country?: string
  state?: string
  city?: string
  postalCode?: string

  // new 
  userId: string
  fullName: string
  userName: string
  email: string
  avatar?: any
  roles: string[]
}

export interface IProfileForm {
  firstName: string
  lastName: string
  address: string
  postalCode: string
  country: string
  state: string
  city: string
  contactEmail: string
  phoneNumber: string
  saveAddress: boolean
}

export type TGetProfileResponse = Omit<
  IProfileForm,
  'address' | 'country' | 'state' | 'city' | 'postalCode'
> & {
  address?: string
  country?: Option
  state?: Option
  city?: Option
  postalCode?: string
}

export type TUploadProfileAvatarRequest = FormData

export type TUploadProfileAvatarResponse = {
  avatar: string
}
