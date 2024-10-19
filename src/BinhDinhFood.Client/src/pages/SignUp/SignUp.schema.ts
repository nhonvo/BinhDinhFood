import * as Yup from 'yup'

const SignUpSchema = Yup.object().shape({

  userName: Yup.string()
    .required("Username is required.")
    .max(100, "Username must not exceed 100 characters."),

  name: Yup.string()
    .required("Name is required.")
    .max(100, "Name must not exceed 100 characters."),

  email: Yup.string()
    .required("Email is required.")
    .max(100, "Email must not exceed 100 characters.")
    .email("Email must be a valid email address."),

  password: Yup.string()
    .required("Password is required.")
    .min(8, "Password must be at least 8 characters long.")
    .matches(/[A-Z]/, "Password must contain at least one uppercase letter.")
    .matches(/[a-z]/, "Password must contain at least one lowercase letter.")
    .matches(/[0-9]/, "Password must contain at least one digit.")
    .matches(/[^a-zA-Z0-9]/, "Password must contain at least one special character."),

  confirmPassword: Yup.string()
    .oneOf([Yup.ref('password')], 'Passwords must match')
    .required('Confirmation password is required'),
    
  acceptTerms: Yup.boolean()
    .oneOf([true], 'You must accept the terms and conditions')
    .required('Accept terms is required')
})

export default SignUpSchema
